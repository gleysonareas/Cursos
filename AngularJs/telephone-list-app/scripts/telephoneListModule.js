// angular.module("telephoneList", []);
angular.module("telephoneList", []).controller("telephoneListCtrl",
    // function ($scope) {}
    // _() = ($scope) => {}
    // _ = ($scope) => {}
    ($scope) => {
        $scope.app = "Lista Telefonica";
        $scope.contacts = [
            { name: "Pedro", telephone: 999998888 },
            { name: "Thiago", telephone: 999998888 },
            { name: "João", telephone: 999998888 }
        ];

        $scope.addContact = (contact) => {
            $scope.contacts.push(angular.copy(contact));
            delete $scope.contact;
        };
    });