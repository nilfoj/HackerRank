//introdução
let variavel = 'String - Alteravel';
console.log(variavel);

variavel = 'String - Alterada';
console.log(variavel);

const variavel1 = 'String - Não Alteravel';
console.log(variavel1);

variavel1 = 'String - Alterada - ERRO';
//<ERRO>


//Numeros
let numeros01 = 1;
console.log(numeros01);

const numeros02 = 2;
console.log(numeros02);
  
const numeros03 = 1.5;
console.log(numeros03);

const numeros04 = '4';
console.log(numeros04);


//<ERRO>
numeros04 = Number.parseInt;
console.log(numeros04);


//Transformando em Inteiro
const numeros05 = Number.parseInt('5');
console.log(numeros05);



//String
let texto01 = "Teste - Aspas Duplas";
console.log(texto01);

let texto02 = 'Teste - Aspas Simples';
console.log(texto02);  
  
//Template > ${}
console.log(`Teste - Template - Acento Agudo + ${texto01}`);

console.log(`Pequenmo teste de Texto` + texto01.toUpperCase());

//toUpperCase()
//toLowerCase()


//Template > ${}
console.log(`Teste - Template - Acento Agudo + ${texto01}`);


// IF, Else, Else IF 
// or > | |
// e > &&
//Negação > ! -- Verdadeiro >> Falso // Falso >> Verdadeiro
const valorini = 0;

const valor01 = 10;
const valor02 = 20;
const valor03 = 30;
const valor04 = 40;
const valor05 = 50;

//Condição 01
if (valorini > valor01) {
    console.log('Valor Inicial menor que Valor 01');
}

else{
    console.log('Valor Inicial maior que Valor 01');
}


//Condição 02
if(valorini >= valor02 || valorini === valor02){
    console.log('Valor Inicial maior ou igual que Valor 02 OUR Valor inicial IGUAL Valor02');
}

else{
    console.log('Valor inicial <= Valor 02 OUR Valor Inicial diferente Valor 02');
}



