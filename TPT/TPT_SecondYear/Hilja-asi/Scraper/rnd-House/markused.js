const request = require("request");
const cheerio = require("cheerio");
const fs = require("fs");

const getMarkused = () => {
  let markused = [];
  request(
    `https://www.kv.ee/?act=search.simple&last_deal_type=3&company_id=&page=1&orderby=ob&page_size=50&deal_type=1&dt_select=3&county=0&search_type=old&parish=&rooms_min=&rooms_max=&price_min=&price_max=&nr_of_people=&area_total_min=&area_total_max=&area_ground_min=&area_ground_max=&floors_min=&floors_max=&energy_certs=&keyword=`,
    (error, response, html) => {
      if (!error && response.statusCode == 200) {
        const $ = cheerio.load(html.toString());
        $(".object-excerpt").each((i, markus) => {
          markused[i] = $(markus).text().toString();
        });
      }

      fs.appendFile("markused.txt", markused + "\n", (err) => {
        if (err) console.log(err);
      });
    }
  );
};
getMarkused();
