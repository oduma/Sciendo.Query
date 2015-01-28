function datacontext() {

    var self = this;
    self.filterByFacet = function (query, resultObservable, errorObservable, filterFieldName, selectedFacetObservable, facetFilteredObservable) {
        return ajaxRequest("get", solrFilterUrl(query(),4,0,filterFieldName, selectedFacetObservable()))
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
                ],
                pageSize: 4
            });

            resultObservable({ message: "Ok", fields: data.Fields, resultRows: data.ResultRows, gridViewModel: grdModel });

            errorObservable();

            facetFilteredObservable(true);

        }
        function getFailed() {
            errorObservable("Error retrieving results.");
            resultObservable({ message: "Not Ok"});
            facetFilteredObservable(false);

        }
    }
    self.doSearch = function (query, resultObservable, errorObservable, facetFilteredObservable, pageInfoObservable) {
        return ajaxRequest("get", solrUrl(query(),pageInfoObservable()))
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
                ]
            });
            resultObservable({ message: "Ok", fields: data.Fields, resultRows: data.ResultRows, gridViewModel: grdModel});

            errorObservable();

            facetFilteredObservable(false);

            pageInfoObservable(data.PageInfo)
        }

        function getFailed() {
            errorObservable("Error retrieving results.");
            resultObservable({ message: "Not Ok" });
            facetFilteredObservable(false);

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
    function solrUrl(id, pageInfo)
    {
        return "/home/search?criteria=" + (id || "") + "&numRows=" + (pageInfo.RowsPerPage || "4") + "&startRow=" + (pageInfo.PageStartRow || "0");
    }

    function solrFilterUrl(id, numRows, startRow, facetName, facetId) { return "/home/filter?criteria=" + (id || "") + "&numRows=" + (numRows || "4") + "&startRow=" + (startRow || "0") + "&facetFieldName=" + (facetName || "") + "&facetFieldValue=" + (facetId || ""); }

};