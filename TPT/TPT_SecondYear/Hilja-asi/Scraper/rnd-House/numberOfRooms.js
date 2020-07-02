const fs = require("fs");

const randomRooms = () => {
  for (let i = 0; i < 202; i++) {
    const rnd = Math.floor(Math.random() * 5 + 1);
    fs.appendFile("rndRooms.txt", rnd + "\n", (err) => {
      if (err) console.log(err);
    });
  }
};
randomRooms();
