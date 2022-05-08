angular.module("helloWorld", []); //Isso cria um modulo
angular.module("helloWorld")
    .controller("helloWorldCtrl",
        function($scope) {
            $scope.message = "Hello World";
        }); //isso faz com que eu de uma localização mais precisa para o meu controler