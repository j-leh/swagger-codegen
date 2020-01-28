/*
 * Swagger Petstore
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * OpenAPI spec version: 1.0.0
 * Contact: apiteam@swagger.io
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 *
 * Swagger Codegen version: 2.4.6-SNAPSHOT
 *
 * Do not edit the class manually.
 *
 */

(function(root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD. Register as an anonymous module.
    define(['petstore/ApiClient'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'));
  } else {
    // Browser globals (root is window)
    if (!root.SwaggerPetstore) {
      root.SwaggerPetstore = {};
    }
    root.SwaggerPetstore.ClassModel = factory(root.SwaggerPetstore.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';

  /**
   * The ClassModel model module.
   * @module petstore/mdl/ClassModel
   * @version 1.0.0
   */

  /**
   * Constructs a new <code>ClassModel</code>.
   * Model for testing model with \"_class\" property
   * @alias module:petstore/mdl/ClassModel
   * @class
   */
  var exports = function() {
  };

  /**
   * Constructs a <code>ClassModel</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:petstore/mdl/ClassModel} obj Optional instance to populate.
   * @return {module:petstore/mdl/ClassModel} The populated <code>ClassModel</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) {
      obj = obj || new exports();
      if (data.hasOwnProperty('_class'))
        obj._class = ApiClient.convertToType(data['_class'], 'String');
    }
    return obj;
  }

  /**
   * @member {String} _class
   */
  exports.prototype._class = undefined;

  return exports;

}));
