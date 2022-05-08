enum Permission {
  ADMIN,
  USER,
  READONLY,
}

console.log(Permission.ADMIN);
console.log(Permission.USER);
console.log(Permission.READONLY);

// Enum constumam ser usados para definir permissões é interessante utilizar esse tipo quando se há a necessidade
// de agrupar as informações para compor uma constante. como dito pode ser substiuido pelas constantes, mais esse
// é mais simples de ser usado.
