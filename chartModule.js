// let generate = require("node-chartist");

module.exports = function(callback) {
    // generate(type, options, data).then(
    //     result => callback(null, result),
    //     error => callback(error)
    // );
    let message = 'Hello from Node at' + new Date().toString();
    callback(null, message);
}