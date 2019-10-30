/* eslint-disable no-unused-vars */
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

        if(method == "GET" || method == "OPTION" || method == "DELETE")
        {
            delete options.body;
        }

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

window.addEventListener("DOMContentLoaded", () =>
{
    fetch("http://demo2.z-bit.ee/todo.json")
        .then((response) => response.json())
        .then((data) =>
        {
            data.forEach(addTask);
        });
});

class Task {
    constructor(rawObj)
    {
        this.id = null;
        this.title = "";
        this.desc = "";
        this.marked_as_done = false;
       
        if(typeof rawObj !== "undefined")
        {
            this.load(rawObj);
        }
    }
   
    save()
    {
        if(this.id) //send PUT
        {
            api.sendRequest("/tasks/" + this.id, "PUT", this);
        }
        else //send POST
        {
            api.sendRequest("/tasks", "POST", this);
        }
    }
    delete()
    {
        api.sendRequest("/tasks/" + this.id, "DELETE")
    }
    load(obj)
    {
        for(let key in obj)
        {
            if(obj.hasOwnProperty(key))
            {
                this[key] = obj[key];
            }
        }
    }
}
// Uue taski loomine
task = new Task();
task.title = "Title";
task.save();

// Serverist tulnud taski loomine
task = new Task({title: "", desc: ""});

function addTask(task)
{
    let row = document.querySelector("#todo-list > .row.hidden");
    let newRow = row.cloneNode(true);
    newRow.classList.remove("hidden");

    if(typeof task !== "undefined")
    {
        newRow._task = new Task(task);
        let taskTitle = newRow.querySelector(".title");
        taskTitle.setAttribute("value", task.title);

        if (typeof task.desc !== "undefined") {
            newRow.querySelector(".desc").value = task.desc;
        }

        let checkbox = newRow.querySelector(".checkbox");
        checkbox.setAttribute("value", task.marked_as_done);
        if (task.marked_as_done  == true) {
            checkbox.checked = true;
        }
        else if (task.marked_as_done == false) {
            checkbox.checked = false;
        }
    }
    else
    {
        newRow._task = new Task();
    }

    let delBtn = newRow.querySelector("input[value=Delete]");
    delBtn.addEventListener("click", deleteRow);

    document.querySelector("#todo-list").appendChild(newRow);
}

function deleteRow(event)
{
    let row = event.currentTarget.parentElement.parentElement;
    row._task.delete();
    row.remove();
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
        deleteAllTasks();
        tasks.forEach((task) => {
            addTask(task);
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

function saveAllTasks()
{
    // let rows = document.querySelector("#todo-list .row:not(.hidden)");
    const list = document.querySelector("#todo-list");
    [...list.children].forEach((child) =>
    {
        if(!child.classList.contains("hidden"))
        {
            child._task.title = child.querySelector("input[name = 'title']").value;
            child._task.desc = child.querySelector("input[name = 'desc']").value;
            child._task.marked_as_done = child.querySelector("input[name = 'marked_as_done']").checked;
            child._task.save();
            console.log("Saved");
        }
    })
}

function deleteAllTasks()
{
    const list = document.querySelector("#todo-list");
    [...list.children].forEach((child) =>
    {
        if(!child.classList.contains("hidden"))
            child.remove();
    })
}