const fs = require("fs");

const randomKorrus = () => {
  for (let i = 0; i < 202; i++) {
    const rnd = Math.floor(Math.random() * 4.9 + 1);
    fs.appendFile("rndKorrus.txt", rnd + "\n", (err) => {
      if (err) console.log(err);
    });
  }
};
randomKorrus();
