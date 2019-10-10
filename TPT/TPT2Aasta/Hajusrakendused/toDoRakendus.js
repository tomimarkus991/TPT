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
                let row = event.currentTarget.parentElement;
                let container = row.parentElement;
                container.removeChild(row);
            };

        window.addEventListener('DOMContentLoaded', () => 
        {
            fetch("http://demo2.z-bit.ee/todo.json")
            .then((response) => response.json())
            .then((data) => 
            {
                console.log(data);
            });
        });