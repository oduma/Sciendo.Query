(function (ko, datacontext) {
    datacontext.result = result;
    datacontext.criteria = criteria;
//    datacontext.resultRow = resultRow;

    //function resultRow(data) {
    //    var self = this;
    //    data = data || {};

    //    // Persisted properties
    //    self.filePath = data.filePath;
    //    self.artist = data.artist;
    //    self.album = data.album;
    //    self.title = data.title;
    //    self.lyrics = data.lyrics;

    //    self.toJson = function () { return ko.toJSON(self) };
    //};

    function criteria(data) {
        var self = this;
        data = data || {};

        // Persisted properties
        self.text = ko.observable(data);

        // Non-persisted properties
        self.toJson = function () { return ko.toJSON(self) };
    };

    function result(data) {
        var self = this;
        data = data || {};

        // Persisted properties
        if (data.length != null)
            self.resultRows = ko.observableArray(data);
        else
            self.resultRows = ko.observableArray();
        self.message = "Ok";

        self.toJson = function () { return ko.toJSON(self) };
    };
})(ko, indexApp.datacontext);