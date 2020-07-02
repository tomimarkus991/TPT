// const users = [
//     { name: 'Peeter1', premium: true },
//     { name: 'Peeter2', premium: false },
//     { name: 'Peeter3', premium: false },
//     { name: 'Peeter4', premium: true },
//     { name: 'Peeter5', premium: false },
//     { name: 'Peeter6', premium: false },
//     { name: 'Peeter7', premium: false },
//     { name: 'Peeter8', premium: false }
// ]

// const premiumUsers = users.filter(user => user.premium);
// console.log(premiumUsers);

// const prices = [10, 30, 15, 20, 45, 56, 123, 52, 32, 12, 52, 12, 5, 86];

// const salePrices = prices.map(price => price * 0.2 + price)
// console.log(salePrices);


// const products = [
//     { name: 'gold star', price: 20 },
//     { name: 'mushroom', price: 40 },
//     { name: 'green shells', price: 30 },
//     { name: 'banana skin', price: 10 },
//     { name: 'red shells', price: 50 }
// ];


// const halfPrices = products.map((product) => {
//     if (product.price > 30) {
//         return { name: product.name, price: product.price / 2 };
//     }
//     else {
//         return { name: product.name, price: product.price };
//     }
// });
// console.log(halfPrices);

// const scores = [
//     { player: 'mario', score: 50 },
//     { player: 'yoshi', score: 30 },
//     { player: 'mario', score: 70 },
//     { player: 'crystal', score: 60 },
//     { player: 'mario', score: 50 },
//     { player: 'yoshi', score: 30 },
//     { player: 'mario', score: 70 },
//     { player: 'crystal', score: 60 },
//     { player: 'mario', score: 50 },
//     { player: 'yoshi', score: 30 },
//     { player: 'mario', score: 70 },
//     { player: 'crystal', score: 60 },
//     { player: 'mario', score: 50 },
//     { player: 'yoshi', score: 30 },
//     { player: 'mario', score: 70 },
//     { player: 'crystal', score: 60 },
//     { player: 'mario', score: 50 },
//     { player: 'yoshi', score: 30 },
//     { player: 'mario', score: 706 },
//     { player: 'crystal', score: 60 }
// ];
// const marioScore = scores.reduce((acc, curr) => {
//     if (curr.player === 'mario') {
//         acc += curr.score;
//     }
//     return acc;
// }, 0)
// console.log(marioScore);

// const prices = [10, 30, 15, 20, 45, 56, 123, 52, 32, 12, 52, 12, 5, 86];

// const firstOver50 = prices.find(price => price > 50);

// console.log(firstOver50);

const products = [
    { name: 'gold star', price: 30 },
    { name: 'green shell', price: 10 },
    { name: 'red shell', price: 40 },
    { name: 'banana skin', price: 5 },
    { name: 'mushroom', price: 50 }
];

const forSale = products
    .filter(product => {
        return { name: product.name, price: product.price > 20 }
    })
    .map(product => {
        return { name: product.name, price: product.price / 2 }
    })
    .sort((a, b) => a.price - b.price);
console.log(forSale);