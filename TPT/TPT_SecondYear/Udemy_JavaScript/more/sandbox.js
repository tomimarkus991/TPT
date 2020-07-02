// const stuff = [1, 2, 3, 4, 5, "kks", 3];

// const puum = [6, 9, ...stuff, "peeter"];

// console.log(puum);

const namesArray = ["ryu", "chanfler", "mrbest", "ryu"];

const namesSet = new Set(namesArray);

const uniqueNames = [...namesSet];
// const uniqueNames = [...new Set(namesArray)];
console.log(uniqueNames);

const ages = new Set();

// ages.add(20);
// ages.add(25);
// ages.add(20);

ages.add(20).add(25).add(20);
console.log(ages);

const ninja = {
  age: 30,
  belt: "black",
};

// ninja["age"] = 30;
// ninja.belt = "orange";

console.log(ninja);
