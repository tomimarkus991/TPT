const fs = require("fs");

const randomKyte = () => {
  for (let i = 0; i < 200; i++) {
    let rnd = Math.floor(Math.random() * 3);
    switch (rnd) {
      case 0:
        rnd = "Õhksoojuspump";
        break;
      case 1:
        rnd = "Konditsioneer";
        break;
      case 2:
        rnd = "Keskküte";
        break;

      default:
        break;
    }
    fs.appendFile("rndKyte.txt", rnd + "\n", (err) => {
      if (err) console.log(err);
    });
  }
};
randomKyte();
