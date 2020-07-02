// example 1 - sorting strings
const names = ['mario', 'shaun', 'chun-li', 'yoshi', 'luigi'];

// console.log(names.sort());
// console.log(names.reverse());



// example 2 - sorting numbers
const scores = [10, 50, 20, 5, 35, 70, 45];

scores.sort((a, b) => a - b); // if A is a bigger number A comes first. If B is a bigger number B will come first
console.log(scores);


// console.log(scores.sort());
// console.log(scores.reverse());
// console.log(scores.sort());

// example 3 - sorting objects
const players = [
    { name: 'mario', score: 20 },
    { name: 'luigi', score: 10 },
    { name: 'chun-li', score: 50 },
    { name: 'yoshi', score: 30 },
    { name: 'bowser', score: 30 },
    { name: 'shaun', score: 70 }
];


// players.sort((a, b) => {
//     if (a.score > b.score) { // jätab suurema paika
//         return 1;
//     } else if (b.score > a.score) { // vahetab väiksemaga koha
//         return -1;
//     } else { // jätab mõlemad paika, sest score on sama suur
//         return 0;
//     }
// });

// players.sort((a, b) => a.score - b.score);
// console.log(players);
