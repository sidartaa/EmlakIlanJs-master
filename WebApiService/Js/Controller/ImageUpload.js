'use strict';
torbaliBurada.directive('myDirectory', ['$parse', function ($parse) {

    function link(scope, element, attrs) {
        
        var model = $parse(attrs.myDirectory);
        element.on('change', function (event) {
            scope.data = [];    //Clear shared scope in case user reqret on the selection
           // element("input[type='file']").val(null);
            scope.imagesrc = [];
            model(scope, { file: event.target.files});
        });
    };

    return {
        link: link
    }
}])

torbaliBurada.service('imgservice', function ($http) {
    var accesstoken = localStorage.getItem('accessToken');
    var authHeaders = {};
    if (accesstoken !== null) {
        if (accesstoken) {
            authHeaders.Authorization = 'Bearer ' + accesstoken;
        }
        }
    this.uploadimg = function ($scope) {
        var resp = $http({
            method: 'POST',
            url: '/api/Upload/user/UserImage',
            data: $scope.formdata,
            headers: {
                'Content-Type': undefined, 'Authorization': authHeaders.Authorization
            }
        });
        return resp;
    };

   
});
torbaliBurada.factory('uploadService', function ($http, $q) {
    return {
        uploadFiles: function ($scope) {

            var request = {
                method: 'POST',
                url: '/api/Upload/user/UserImage',
                data: $scope.formdata,
                headers: {
                    'Content-Type': undefined
                }
            };
          //  var resp = $http(request);
            // SEND THE FILES.
            return $http(request)
                .then(
                function (response) {
                    if (typeof response.data === 'string') {
                        return response.data;
                    } else {
                        return $q.reject(response.data);
                    }
                },
                function (response) {
                    return $q.reject(response.data);
                }
                );
        }

    };
})
