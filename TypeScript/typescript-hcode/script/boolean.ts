let admin: boolean = true;

admin = Boolean("1"); // qualquer valor diferente de 0, null, undefined desde que ele seja um numero ou uma string, sempre irá retornar true.

console.log(admin);

let password = "1234";
let passwordSecurity: boolean; 

passwordSecurity = (password.length > 8);

console.log(passwordSecurity);