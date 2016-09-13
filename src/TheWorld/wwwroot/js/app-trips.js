(function () {

    "use strict";

    //Creating the module
    angular.module("app-trips", ["ngMessages", "simpleControls", "ngRoute"])
        .config(function ($routeProvider) {
            $routeProvider.when("/", {
                controller: "tripsController as vm",
                templateUrl: "/views/tripsView.html"
            });

            $routeProvider.when("/editor/:tripName", {
                controller: "tripEditorController as vm",
                templateUrl: "/views/tripEditorView.html"
            });

            $routeProvider.otherwise({
                redirectTo: "/"
            });
        });


})();