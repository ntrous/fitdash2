var angularApp = angular.module('angularApp', [
  'ui.bootstrap',
  'ngRoute',
  'ngCookies',
  'angularApp.controllers',
  'angularApp.service',
  'angularApp.common',
  'angulartics',
  'angulartics.google.analytics',
  'LocalStorageModule'
]).constant('_', window._);

var angularAppControllers = angular.module('angularApp.controllers', ['angularApp.service']);
var angularAppServices = angular.module('angularApp.service', []);
var angularAppCommon = angular.module('angularApp.common', []);

angularApp.config(['$routeProvider', '$locationProvider',
    function ($routeProvider, $locationProvider) {
        $routeProvider
        .when('/', {
            templateUrl: '../AngularApp/Home/Home.html',
            controller: 'HomeCtrl',
            reloadOnSearch: false,
            caseInsensitiveMatch: true,
            title: 'Home Page',
            description: 'Home Page Description',
            resolve: { }
        })
        .when('/Login', {
            templateUrl: '../AngularApp/Account/Login.html',
            controller: 'loginCtrl',
            title: 'Login',
            caseInsensitiveMatch: true
        })
        .otherwise({
            redirectTo: '/'
        });

        $locationProvider.html5Mode(true);
    }
]);

angularApp.run(['$rootScope', '$routeParams', function ($rootScope, $routeParams) {
    $rootScope.$on('$routeChangeSuccess', function (event, current, previous) {
        if (current.hasOwnProperty('$$route')) {
            // Sets the title and description for each page
            $rootScope.title = current.$$route.title;
            $rootScope.description = current.$$route.description;
        }
        else {
            $rootScope.title = 'Default Title Goes Here';
            $rootScope.description = 'Default description goes here';
        }
    });
}]);

angularApp.run(['authService', function (authService) {
    authService.fillAuthData();
}]);

angularApp.config(function ($httpProvider) {
    $httpProvider.interceptors.push('authInterceptorService');
});