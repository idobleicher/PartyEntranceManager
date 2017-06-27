var module = angular.module('IndexApp', []);

module.config(['$qProvider', function ($qProvider) {
    $qProvider.errorOnUnhandledRejections(false);
}]);

module.controller('indexController', function ($scope, $rootScope, $window, $http, $q, $exceptionHandler) {
    


    $scope.addedUsers = function () {
        var f = document.getElementById('file').files[0],
            r = new FileReader();
        r.onloadend = function (e) {
            var data = e.target.result;

            $http({
                method: "POST",
                url: "/api/Users/UploadFile",
                data: data
            });

        }
        r.readAsBinaryString(f);
    }


    $http({
        url: '../Users/Users.json',
        dataType: 'json',
        method: 'Get',
        data: '',
        headers: {
            "Content-Type": "application/json"
        }
    }).then(function (res) {
        $scope.tabelsData = res.data
    }), function (res) {
        $scope.tabelsData = res.data
    };


    $scope.foo = 0;

    $scope.addPeople = 0;

    function stringIsNumber(n) {
        return !isNaN(parseFloat(n)) && isFinite(n);
    }
    $scope.bot = function (idx, foo) {
        if (stringIsNumber(foo)) {
            $scope.tabelsData[idx].bottle = parseInt($scope.tabelsData[idx].bottle) + parseInt(foo);
        }
    }

    $scope.addYach = function () {
        var yah = { "name": $scope.txtName, "people": 0, "bottle": 0, "salary": 10, "precent": 0.1 }
        $scope.tabelsData.push(yah);
    }

    $scope.Del = function (idx) {
        $scope.tabelsData.splice(idx, 1);
    };

    $scope.accept = function (idx, foo) {
        if (stringIsNumber(foo)) {
            $scope.tabelsData[idx].people = parseInt($scope.tabelsData[idx].people) + parseInt(foo);
        }

    }

    $scope.Export = function () {
        $scope.Save();

        window.open('/Files/Export', '_blank', '');
    };

    $scope.Save = function () {

            $http({
                method: "POST",
                url: "/api/Users/Opm",
                data: JSON.stringify($scope.tabelsData)
            });

       };

       $scope.load = function () {

       };

       $scope.Reset = function () {
           for (var i = 0; i < $scope.tabelsData.length; i++) {
               $scope.tabelsData[i].people = 0;
               $scope.tabelsData[i].bottle = 0;
           }
       };

   }
   );
