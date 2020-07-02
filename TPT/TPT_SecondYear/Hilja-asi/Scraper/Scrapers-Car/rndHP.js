const fs = require("fs");

const randomHP = () => {
  for (let i = 0; i < 202; i++) {
    const rnd = Math.round(Math.floor(Math.random() * 150 + 1) * 1.34102, 2);
    fs.appendFile("rndHP.txt", rnd + "\n", (err) => {
      if (err) console.log(err);
    });
  }
};
randomHP();
