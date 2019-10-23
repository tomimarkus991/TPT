/* eslint-disable no-unused-vars */

window.addEventListener("DOMContentLoaded", () =>
{
    fetch("http://demo2.z-bit.ee/todo.json")
        .then((response) => response.json())
        .then((data) =>
        {
            data.forEach(element =>
            {

                let row = document.querySelector("#todo-list > .row.hidden");
                let newRow = row.cloneNode(true);

                newRow.classList.remove("hidden");

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

                let delBtn = newRow.querySelector("input[value=Delete]");
                delBtn.addEventListener("click", deleteRow);

                document.querySelector("#todo-list").appendChild(newRow);
            });
        });
});

function addToDo()
{
    let row = document.querySelector("#todo-list > .row.hidden");
    let newRow = row.cloneNode(true);

    newRow.classList.remove("hidden");

    let delBtn = newRow.querySelector("input[value=Delete]");
    delBtn.addEventListener("click", deleteRow);

    document.querySelector("#todo-list").appendChild(newRow);
}
function deleteRow(event)
{
    event.currentTarget.parentElement.parentElement.remove();
}
function parseJSON(response)
{
    console.log(response);
    return response.json();
}
function login()
{
    let username =  document.querySelector("input[name = 'username']").value;
    let password =  document.querySelector("input[name = 'password']").value;

    api.sendRequest("/users/get-token", "POST", {username, password}, (user) => {console.log(user); api.token = user.access_token;
    api.sendRequest("/tasks", "GET", null, (tasks) => {
        clearTodoList();
        [tasks].forEach((task) => {
            addToDo(task);
            });
        });
     });

}

function register()
{
    let username =  document.querySelector("input[name = 'username']").value;
    let password =  document.querySelector("input[name = 'password']").value;

    api.sendRequest("/users", "POST", {username, newPassword: password}, (data) => {console.log(data);
    });
}
function clearTodoList()
{
    const list = document.querySelector("#todo-list");
    [...list.children].forEach((child) =>
    {
        if(!child.classList.contains("hidden"))
            child.remove();
    })
}
class Demo2Api
{
    constructor()
    {
        this.baseUrl = "http://demo2.z-bit.ee"
    }
    sendRequest(url, method, body, callback)
    {
        let username =  document.querySelector("input[name = 'username']").value;
        let password =  document.querySelector("input[name = 'password']").value;

        const options =
        {
            method,
            headers:
            {
                "Content-Type": "application/json",
            },
            body: JSON.stringify(body),
        };

        if(method == "GET" || method == "OPTION") delete options.body;

        if(this.token !== null)
        {
            options.headers["Authorization"] = "Bearer " + this.token;
        }
        fetch(this.baseUrl + url, options)
        .then((response) => response.json())
        .then(callback);
    }
}
const api = new Demo2Api();