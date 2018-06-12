var MainController = function ($scope, $http) {
    $scope.models = {
        tabletemplates: [
            { id:"greenTable", Template:"Green Table" }
            , { id:"blueTable", Template:"Blue Table" }
            , { id:"purpleHorizon", Template:"Purple Horizon" }
            , { id:"darkTable", Template:"Dark Table" }
        ]
        , totalCount: 0
        , currentPlayers: []
        , selectedStyle: "greenTable"
        , displayInformation: ""
        , currentPage:1
        , pageSize: 5     
        , previousPageClassName: "linkdisabled"
        , nextPageClassName: ""
      
    };

    $scope.getPlayersByCurrentPage = function (currentPage) {
       
        $http.get("api/players/GetPlayersBy?currentPage=" + currentPage + "&pageSize=" + $scope.models.pageSize)
            .success(function (data) {
                $scope.models.currentPlayers = data;

                var totalNumberDisplayed = currentPage * $scope.models.pageSize;                
                var exceededTheTotalCount = totalNumberDisplayed > $scope.models.totalCount;                
                var totalNumberToDisplay = totalNumberDisplayed;

                if (exceededTheTotalCount) {
                    totalNumberToDisplay = $scope.models.totalCount
                    $scope.models.nextPageClassName = "linkdisabled"
                }
                else {
                    $scope.models.nextPageClassName = ""
                }


                $scope.models.displayInformation = "Displaying " + totalNumberToDisplay + " of " + $scope.models.totalCount

            }).error(function (error) {
                console.log(error);
            })
    };
    
    $http.get("api/players/GetTotalNumberOfPlayers")
        .success(function (data) {
            $scope.models.totalCount = data;
          
            $scope.models.displayInformation = "Displaying "+$scope.models.currentPage*$scope.models.pageSize+" of " + $scope.models.totalCount
        }).error(function (error) {
            console.log(error);
        })

    $scope.getPlayersByCurrentPage($scope.models.currentPage);
               
    $scope.selectedTemplate = $scope.models.tabletemplates[0];

    $scope.changeTemplate = function (template) {
        $scope.models.selectedStyle = template.id;       
    }    

    $scope.goBack = function () {
        $scope.models.currentPage = $scope.models.currentPage - 1;
        if ($scope.models.currentPage === 1) {
            $scope.models.previousPageClassName = "linkdisabled"
        }

        $scope.getPlayersByCurrentPage($scope.models.currentPage);
    }

    $scope.goNext = function () {
        $scope.models.currentPage = $scope.models.currentPage + 1;        
        $scope.models.previousPageClassName = "";
        $scope.getPlayersByCurrentPage($scope.models.currentPage);
    }
}
MainController.$inject = ['$scope','$http'];