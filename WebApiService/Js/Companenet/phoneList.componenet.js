// Register `phoneList` component, along with its associated controller and template
angular.
  module('phonecatApp').
  component('phoneList', {
      template:
          '<ul>' +
            '<li ng-repeat="phone in $ctrl.phones">' +
              '<span>{{phone.name}}</span>' +
              '<p>{{phone.snippet}}</p>' +
            '</li>' +
          '</ul>',
      controller: function PhoneListController() {
          this.phones = [
            {
                name: 'Nexus S',
                snippet: 'Fast just got faster with Nexus S.'
            }, {
                name: 'Motorola XOOM™ with Wi-Fi',
                snippet: 'The Next, Next Generation tablet.'
            }, {
                name: 'MOTOROLA XOOM™',
                snippet: 'The Next, Next Generation tablet.'
            }
          ];
      }
  });

//<phone-list></phone-list> 
//<select name="select" class="form-control" id="assetcategory" ng-model="asset.category" required>
//                      <option></option>
//                      <option>Furniture</option>
//                      <option>Stationary</option>
//                      <option>Electrical</option>
//                  </select>
//                  <span ng-show="ajaxform.select.$invalid && ajaxform.select.$dirty || ajaxform.select.$invalid && ajaxform.$submitted " style="color: red">*Category Required</span>
                    