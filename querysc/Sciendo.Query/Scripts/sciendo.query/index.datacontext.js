function datacontext() {

    var self = this;
    self.doSearch=function (query, resultObservable, errorObservable) {
        return ajaxRequest("get", solrUrl(query()))
            .done(getSucceeded)
            .fail(getFailed);

        function getSucceeded(data) {
            //errorObservable(data);
            //var mappedResults = $.map(data, function (list) { return new createResults(list); });
            resultObservable({ message: "Ok" ,resultRows:data});
            errorObservable();
        }

        function getFailed() {
            errorObservable("Error retrieving results.");
            resultObservable({ message: "Not Ok" });
        }
    }
    function createResultRow(data) {
        return new datacontext.resultRow(data); // todoItem is injected by todo.model.js
    }

    function createResults(data) {

        return new datacontext.result(data); // todoList is injected by todo.model.js
    }
    // Private
    function clearErrorMessage(entity) { entity.errorMessage(null); }
    function ajaxRequest(type, url, data, dataType) { // Ajax helper
        var options = {
            dataType: dataType || "json",
            contentType: "application/json",
            cache: false,
            type: type,
            data: data ? data.toJson() : null
        };
        var antiForgeryToken = $("#antiForgeryToken").val();
        if (antiForgeryToken) {
            options.headers = {
                'RequestVerificationToken': antiForgeryToken
            }
        }
        return $.ajax(url, options);
    }
    // routes
    function solrUrl(id) { return "/home/search?criteria=" + (id || ""); }
};