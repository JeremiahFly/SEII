(function () {
    'use strict';

    angular
        .module('app')
        .controller('indexController', indexController);


    function indexController($scope, $q, indexService) {
        $scope.cards = {
            cards: null
        };

        $scope.formCards = {
            c1:null,
            c2:null,
            c3:null,
            c4:null
        }

        $scope.error = {
            message: ""
        }

        $scope.accept = function accept() {
            var tmp = {
                cards: [
                    {
                        value: $scope.formCards.c1
                    },
                    {
                        value: $scope.formCards.c2
                    },
                    {
                        value: $scope.formCards.c3
                    },
                    {
                        value: $scope.formCards.c4
                    }

                ]
            }
            indexService.setCards(tmp).then(function (data) {
                $scope.getData();
            });
            
            
        }

        $scope.getData = function getData() {
            indexService.getData().then(function (data) {
                $scope.cards = data;
                $scope.formCards.c1 = data.cards[0].value;
                $scope.formCards.c2 = data.cards[1].value;
                $scope.formCards.c3 = data.cards[2].value;
                $scope.formCards.c4 = data.cards[3].value;
            });
        }

        $scope.getData();



    }
})();
