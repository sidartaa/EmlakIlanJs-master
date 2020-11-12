torbaliBurada.controller('MenuController', function ($scope) {
    
    var accesstoken = localStorage.getItem('accessToken');
    $scope.token = accesstoken;
   
    $scope.$watch('handle', function (newValue, oldValue) {
        $scope.token = localStorage.getItem('accessToken');
        console.log(newValue + " " + oldValue);
       
    });
    $scope.$on('handle', function (event, args) {
        console.log("change detected")
        //any other action can be perfomed here
    });
});