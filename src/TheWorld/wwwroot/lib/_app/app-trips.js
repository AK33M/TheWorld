!function(){"use strict";angular.module("app-trips",["ngMessages","simpleControls","ngRoute"]).config(["$routeProvider",function(e){e.when("/",{controller:"tripsController as vm",templateUrl:"/views/tripsView.html"}),e.when("/editor/:tripName",{controller:"tripEditorController as vm",templateUrl:"/views/tripEditorView.html"}),e.otherwise({redirectTo:"/"})}])}();