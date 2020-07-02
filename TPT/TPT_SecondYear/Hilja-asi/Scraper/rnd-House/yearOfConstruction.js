const fs = require("fs");

const rndYearOfConstruction = () => {
  for (let i = 0; i < 202; i++) {
    const rnd = Math.floor(Math.random() * 4.6 * 3.3 + 1995);
    fs.appendFile("rndConstructionDate.txt", rnd + "\n", (err) => {
      if (err) console.log(err);
    });
  }
};
rndYearOfConstruction();
