
window.addEventListener('DOMContentLoaded', () => {
    fetch("http://demo2.z-bit.ee/todo.json")
        .then((response) => response.json())
        .then((data) => {
            data.forEach(element =>{

                let row = document.querySelector("#todo-list > .row.hidden");
                newRow = row.cloneNode(true);

                newRow.classList.remove("hidden");

                document.querySelector("#todo-list").appendChild(newRow);

                console.log(element);
            });
        });
});

function addToDo(element) {
    let row = document.querySelector("#todo-list > .row.hidden");
    let newRow = row.cloneNode(true);

    newRow.classList.remove("hidden");

    if(typeof element !== "undefined")
    {
        let taskTitle = newRow.querySelector(".title");
                taskTitle.setAttribute("value", element.title);

                if (typeof element.desc !== "undefined")
                {
                    newRow.querySelector(".description").value = element.desc;
                }

                let checkbox = newRow.querySelector(".checkbox");
                checkbox.setAttribute("value", element.markedAsDone);
                if (element.markedAsDone == true)
                {
                    checkbox.checked = true;
                }
                else if (element.markedAsDone == false)
                {
                    checkbox.checked = false;
                }
    }

    let delBtn = newRow.querySelector("input[value=Delete]");
    delBtn.addEventListener("click", deleteRow);

    document.querySelector("#todo-list").appendChild(newRow);
}

function deleteRow(event) {
    event.currentTarget.parentElement.parentElement.remove();
};