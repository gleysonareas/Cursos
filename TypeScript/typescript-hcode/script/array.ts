const categoryMovie: string[] = ['Action', 'Adventure', 'Terror'];

categoryMovie.push('Romance'); //Utilizando o metodo push é possivel adicionar objetos em um array.

const yearMovie: Array<number> = [];

for (let year = 2000; year <= new Date().getFullYear(); year++) {
    yearMovie.push(year);
}
console.log(yearMovie);