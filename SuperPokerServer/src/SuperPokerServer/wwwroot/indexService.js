(function () {
    'use strict';

    angular
        .module('app')
        .factory('indexService', indexFactory);

    function indexFactory($http, $q) {
        var service = {
            getData: getData,
            setCards: setCards
        };

        return service;

        function getData() {
            var deferred = $q.defer();
            $http.get('api/SuperPoker').then(function (responce) {
                deferred.resolve(responce.data);
            });
            return deferred.promise;
        }

        function setCards(cards) {
            var deferred = $q.defer();
            $http.post('api/SuperPoker', cards).then(function (responce) {
                deferred.resolve(responce.data);
            });
            return deferred.promise;
        }
    }
})();