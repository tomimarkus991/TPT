const list = document.querySelector("ul");
const form = document.querySelector("form");
let input = document.querySelector("#recipe");

const addRecipe = (recipe, id) => {
  let time = recipe.created_at.toDate();
  let title = recipe.title;
  let html = `<li data-id=${id}><div>${title}</div><div>${time}</div>
  <button class="btn btn-danger btn-sm my-y">Delete</button></li>`;

  list.innerHTML += html;
  input.value = "";
};

const deleteRecipe = (id) => {
  const recipes = document.querySelectorAll("li");
  recipes.forEach((recipe) => {
    if (recipe.getAttribute("data-id") === id) {
      recipe.remove();
    }
  });
};

// get recipes
db.collection("recipes").onSnapshot((snapshot) => {
  snapshot.docChanges().forEach((change) => {
    const doc = change.doc;
    if (change.type === "added") {
      addRecipe(doc.data(), doc.id);
    } else if (change.type === "removed") {
      deleteRecipe(doc.id);
    }
  });
});

// add recipes
form.addEventListener("submit", (e) => {
  e.preventDefault();
  const now = new Date();

  const recipe = {
    title: form.recipe.value,
    created_at: firebase.firestore.Timestamp.fromDate(now),
  };
  db.collection("recipes")
    .add(recipe)
    .then(() => {
      console.log("added your thingy");
    })
    .catch((err) => {
      console.log(err);
    });
});

// delete recipes
list.addEventListener("click", (e) => {
  if (e.target.tagName === "BUTTON") {
    const id = e.target.parentElement.getAttribute("data-id");
    db.collection("recipes")
      .doc(id)
      .delete()
      .then(() => {
        console.log("deleted");
      })
      .catch((err) => {
        console.log(err);
      });
  }
});
