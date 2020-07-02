const request = require("request");
const cheerio = require("cheerio");
const fs = require("fs");

const getMark = () => {
  request(
    "https://www.auto24.ee/kasutatud/nimekiri.php?bn=2&a=100&aj=&g1=1000&g2=10000&ae=2&af=200&ag=0&ag=1&otsi=otsi",
    (error, response, html) => {
      if (!error && response.statusCode == 200) {
        const links = [];
        const $ = cheerio.load(html.toString());
        $(".make_and_model a").each((i, link) => {
          links[i] = $(link).attr("href");
        });
        links.forEach((link) => {
          let margid = [];
          request(`https://www.auto24.ee${link}`, (error, response, html) => {
            if (!error && response.statusCode == 200) {
              const $ = cheerio.load(html.toString());
              $(".tpl-content").each((i, mark) => {
                const str = $(mark).find("h1").text().toString();
                let wordsArray = str.split(" ");
                let result = wordsArray[0] + " " + wordsArray[1];
                margid[i] = result;
              });
            }

            fs.appendFile("margid.txt", margid + "\n", (err) => {
              if (err) console.log(err);
            });
          });
        });
      }
    }
  );
};

getMark();
