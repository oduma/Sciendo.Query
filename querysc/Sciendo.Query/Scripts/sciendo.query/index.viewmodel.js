function indexViewModel() {
    var self = this;
    self.criteria = ko.observable("Search for");
    self.resultData = ko.observable(),
    self.error = ko.observable(),
    self.getResults = function () {
        (new datacontext()).doSearch(self.criteria, self.resultData, self.error);
    }
}

// Initiate the Knockout bindings
ko.applyBindings(new indexViewModel());
