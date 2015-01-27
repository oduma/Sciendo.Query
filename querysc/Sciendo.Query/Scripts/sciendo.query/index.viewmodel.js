function indexViewModel() {
    var self = this;
    self.criteria = ko.observable("Search for");
    self.resultData = ko.observable(),
    self.error = ko.observable(),
    self.selectedFacetValue = ko.observable(),
    self.hasFacets = ko.computed(function () {
        return self.resultData()!=null && self.resultData().fields!=null;
    }, self);
    self.getResults = function () {
        (new datacontext()).doSearch(self.criteria, self.resultData, self.error);
    }
    self.facetSelected=function()
    {
        (new datacontext()).filterByFacet(self.criteria, self.resultData, self.error, self.selectedFacetValue);
    }
}

// Initiate the Knockout bindings
ko.applyBindings(new indexViewModel());
