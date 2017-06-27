var module = angular.module('IndexApp', []);

module.controller('indexController', function ($scope, $rootScope, $window, $http, $q, $exceptionHandler) {


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

    $scope.bot = function (idx, foo) {
        $scope.tabelsData[idx].bottle = parseInt($scope.tabelsData[idx].bottle) + parseInt(foo);
        //var result = $http.get('http://localhost:50010/api/Users/addBottle?name=' + $scope.tabelsData[idx].name + '&price=' + foo).then(function (res) {
        //  result = res.data
        //});
    }

    $scope.addYach = function () {
        var yah = { "name": $scope.txtName, "people": 0, "bottle": 0, "salary": 0, "precent": 0.1 }
        $scope.tabelsData.push(yah);
    }

    $scope.Del = function (idx) {
        $scope.tabelsData.splice(idx, 1);
        //$scope.tabelsData[idx].remove();
    };

    $scope.accept = function (idx,foo) {
        $scope.tabelsData[idx].people = parseInt($scope.tabelsData[idx].people) + parseInt(foo);
        //var result = $http.get('http://localhost:50010/api/Users/Update?name=' + $scope.tabelsData[idx].name + '&howmuch=' + foo).then(function (res) {
        //    result = res.data
        //});
    }

    $scope.Export = function () {
        $scope.Save();

        window.open('http://localhost:50010/Files/Export', '_blank', '');
        // window.open('http://localhost:50010/api/Users/GetFile?n=3', '_blank', '');

        // var result = $http.get('http://localhost:50010/api/Users/GetFile?n=3').then(function (res) {
        //    result = res.data;
        //});

    };

    $scope.Save = function () {
        //for (var i = 0; i < $scope.tabelsData.length; i++) {
        //    var result = $http.get('http://localhost:50010/api/Users/Set?name=' + $scope.tabelsData[i].name + '&amount=' + $scope.tabelsData[i].people + '&bottle=' + $scope.tabelsData[i].bottle).then(function (res) {
        //        result = res.data;
        //    })
        //};
        //$qProvider.errorOnUnhandledRejections(false);
        //$scope.tableSecond;
        //for (var i = 1; i < $scope.tabelsData.length; i++)
        //{
        //    if(i % 10 == 0 || i == $scope.tabelsData.length - 1)
        //    {
        //        var result = $http.get('http://localhost:50010/api/Users/SetUsers?Json=' + JSON.stringify($scope.tableSecond)).then(function (res) {
        //            result = res.data;

        //        });
        //        $scope.tableSecond = undefined;
        //    }
        //    var yah = { "name": $scope.tabelsData[i].name, "people": $scope.tabelsData[i].people, "bottle": $scope.tabelsData[i], "salary": 0, "precent": 0.1 }
        //    $scope.tableSecond.push($scope.tabelsData[i]);

        //}

        $http({
            url: "http://localhost:50010/api/Users/SetUsers",
            method: "POST",
            data: {'Json' : JSON.stringify($scope.tabelsData)},
            headers: { 'Content-Type': 'application/x-www-form-urlencoded' },
            withCredentials: true,
        }).then(function (data, status, headers, config) {
            console.log(data);
        })

            //   var result = $http.get('http://localhost:50010/api/Users/SetUsers?Json=' + JSON.stringify($scope.tabelsData)).then(function (res) {
            //     result = res.data;

            //});

        //$http({
        //    url: 'http://localhost:50010/api/Users/SetUsers',
        //    dataType: 'json',
        //    method: 'POST',
        //    data: { 'Json': JSON.stringify($scope.tabelsData) },
        //    headers: {
        //        "Content-Type": "application/json"
        //    }
        //}).then(function (res) {
        //    $scope.tabelsData = res.data
        //}), function (res) {
        //    $scope.tabelsData = res.data
        //};

       //    $http.post('http://localhost:50010/api/Users/SetUsers?Json=', JSON.stringify($scope.tabelsData)).
       //then(function (res) {
       //  //  $scope.tabelsData = res.data
       //}), function (res) {
       //   // $scope.tabelsData = res.data
       //};

           //var result = $http.get('http://localhost:50010/api/Users/Save?number=1').then(function (res) {
           //    result = res.data;

           //});

           //module.run(function ($rootScope, $templateCache) {
           //    $rootScope.$on('$viewContentLoaded', function () {
           //        $templateCache.removeAll();
           //    });
           //});

       };

       $scope.load = function () {
           //$http({
           //    url: '../Users/Users.json',
           //    dataType: 'json',
           //    method: 'Get',
           //    data: '',
           //    headers: {
           //        "Content-Type": "application/json"
           //    }
           //}).then(function (dat) {
           //    $scope.tabelsData = dat.data
           //}), function (dat) {
           //    $scope.tabelsData = dat.data
           //};
       };

       $scope.Reset = function () {
           //var result = $http.get('http://localhost:64308/api/Users/Resete?number=1').then(function (res) {
           //    result = res.data
           //});
           for (var i = 0; i < $scope.tabelsData.length; i++) {
               $scope.tabelsData[i].people = 0;
               $scope.tabelsData[i].bottle = 0;
           }
       };

   }
   );
