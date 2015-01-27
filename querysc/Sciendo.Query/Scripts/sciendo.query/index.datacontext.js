function datacontext() {

    var self = this;
    self.filterByFacet = function (query, resultObservable, errorObservable, selectedFacetObservable) {
        var facetFields = resultObservable().fields;
        return ajaxRequest("get", solrFilterUrl(query(),selectedFacetObservable()))
            .done(getSucceeded)
            .fail(getFailed);

        function getSucceeded(data) {
            var grdModel = new ko.simpleGrid.viewModel({
                data: data.ResultRows,
                columns: [
                    { headerText: "File Path", rowText: "file_path" },
                    { headerText: "Album", rowText: "album" },
                    { headerText: "Artist", rowText: "artist" },
                    { headerText: "Title", rowText: "title" },
                    { headerText: "Lyrics", rowText: "lyrics" }
                ], pageSize: 4
            });

            resultObservable({ message: "Ok", fields: facetFields, resultRows: data.ResultRows, gridViewModel: grdModel });

            errorObservable();

        }
        function getFailed() {
            errorObservable("Error retrieving results.");
            resultObservable({ message: "Not Ok"});

        }
    }
    self.doSearch=function (query, resultObservable, errorObservable) {
        return ajaxRequest("get", solrUrl(query()))
            .done(getSucceeded)
            .fail(getFailed);

        function getSucceeded(data) {
            var grdModel = new ko.simpleGrid.viewModel({
                data: data.ResultRows,
                columns: [
                    { headerText: "File Path", rowText: "file_path" },
                    { headerText: "Album", rowText: "album" },
                    { headerText: "Artist", rowText: "artist" },
                    { headerText: "Title", rowText: "title" },
                    { headerText: "Lyrics", rowText: "lyrics" }
                ], pageSize: 4
            });
            resultObservable({ message: "Ok", fields: data.Fields, resultRows: data.ResultRows, gridViewModel: grdModel});

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

    function solrFilterUrl(id,facetId) { return "/home/filter?criteria=" + (id || "") + "&facet=" +(facetId||""); }

};