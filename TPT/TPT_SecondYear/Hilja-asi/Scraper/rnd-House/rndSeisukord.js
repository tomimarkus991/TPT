const fs = require("fs");

const randomSeisukord = () => {
  for (let i = 0; i < 200; i++) {
    let rnd = Math.floor(Math.random() * 3);
    switch (rnd) {
      case 0:
        rnd = "Uus";
        break;
      case 1:
        rnd = "Vajab renoveerimist";
        break;
      case 2:
        rnd = "Heas korras";
        break;

      default:
        break;
    }
    fs.appendFile("rndSeisukord.txt", rnd + "\n", (err) => {
      if (err) console.log(err);
    });
  }
};
randomSeisukord();
