var mApp = angular.module('mApp');

mApp.controller('testController', function ($scope, $http) {

    $scope.items = [];

    $scope.testParams = {
        count: 0
    };

    $scope.updateItems = function () {
        $http({ method: 'GET', url: '/GetItems', params: { 'count': $scope.testParams.count } }).
         success(function (data) {
             console.log(data);
             $scope.items = data;

             //$scope.items = [{ "name": "Ata", "email": "test@test1.com" }];
         })
    };    

});