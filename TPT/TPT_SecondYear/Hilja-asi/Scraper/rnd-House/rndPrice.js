const fs = require("fs");

const rndPrice = () => {
  for (let i = 0; i < 202; i++) {
    const rnd = Math.floor(Math.random() * 140000) + 160000;
    fs.appendFile("rndPrice.txt", rnd + "\n", (err) => {
      if (err) console.log(err);
    });
  }
};
rndPrice();
