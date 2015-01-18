//window.indexApp.indexViewModel = (function (ko, datacontext) {
//        var result = ko.observable(),
//        error = ko.observable(),
//        criteria=ko.observable(),
//        getResults = function () {
//            datacontext.doSearch(criteria, result, error);
//        }
//    return {
//        result: result,
//        error: error,
//        criteria: criteria,
//        getResults: getResults
//    };

//})(ko, indexApp.datacontext);

//// Initiate the Knockout bindings
//ko.applyBindings(window.indexApp.indexViewModel);

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
