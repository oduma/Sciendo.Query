function indexViewModel() {
    var self = this;
    self.criteria = ko.observable("Search for");
    self.resultData = ko.observable(),
    self.error = ko.observable(),
    self.selectedFacetValue = ko.observable(),
    self.facetFiltered=ko.observable(false),
    self.hasFacets = ko.computed(function () {
        return self.resultData()!=null && self.resultData().fields!=null;
    }, self);
    self.getResults = function () {
        (new datacontext()).doSearch(self.criteria, self.resultData, self.error, self.facetFiltered);
    }
    self.artistFacetSelected=function()
    {
        (new datacontext()).filterByFacet(self.criteria, self.resultData, self.error, "artist_f", self.selectedFacetValue,self.facetFiltered);
    }
    self.extensionFacetSelected = function () {
        (new datacontext()).filterByFacet(self.criteria, self.resultData, self.error, "extension_f", self.selectedFacetValue, self.facetFiltered);
    }
    self.letterFacetSelected = function () {
        (new datacontext()).filterByFacet(self.criteria, self.resultData, self.error, "letter_f", self.selectedFacetValue, self.facetFiltered);
    }
}

// Initiate the Knockout bindings
ko.applyBindings(new indexViewModel());
