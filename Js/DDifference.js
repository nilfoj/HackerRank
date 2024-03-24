let somaDiagonal0 = 0;
let somaDiagonal1 = 0;

for(let i = 0 ; i<arr.length ; i++) {

    somaDiagonal0 += arr[i][i];
    somaDiagonal1 += arr[i][(arr.length)-(i+1)];
}

return Math.abs(somaDiagonal0 - somaDiagonal1);