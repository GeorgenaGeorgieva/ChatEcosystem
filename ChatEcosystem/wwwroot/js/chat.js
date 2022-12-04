class Message {
    constructor(username, text, createdon) {
        this.username = username;
        this.text = text;
        this.createdon = createdon;
    }
}

// userName is declared in razor page.
const username = userName;
const textInput = document.getElementById('messageText');
const createdonInput = document.getElementById('createdon');
const chat = document.getElementById('chat');
const messagesQueue = [];

document.getElementById('submitButton').addEventListener('click', () => {
    var currentdate = new Date();
    createdon.innerHTML =
        (currentdate.getMonth() + 1) + "/"
        + currentdate.getDate() + "/"
        + currentdate.getFullYear() + " "
        + currentdate.toLocaleString('en-US', { hour: 'numeric', minute: 'numeric', hour12: true })
});

function clearInputField() {
    messagesQueue.push(textInput.value);
    textInput.value = "";
}

function sendMessage() {
    let text = messagesQueue.shift() || "";
    if (text.trim() === "") return;
    
    let createdon = new Date();
    let message = new Message(username, text);
    sendMessageToHub(message);
}

function addMessageToChat(message) {
    let isCurrentUserMessage = message.userName === username;

    let container = document.createElement('div');
    container.className = isCurrentUserMessage ? "container darker" : "container";

    let sender = document.createElement('p');
    sender.className = "sender";
    sender.innerHTML = message.userName;
    let text = document.createElement('p');
    text.innerHTML = message.text;

    let createdon = document.createElement('span');
    createdon.className = isCurrentUserMessage ? "time-left" : "time-right";
    var currentdate = new Date();
    createdon.innerHTML = 
        (currentdate.getMonth() + 1) + "/"
        + currentdate.getDate() + "/"
        + currentdate.getFullYear() + " "
        + currentdate.toLocaleString('en-US', { hour: 'numeric', minute: 'numeric', hour12: true })

    container.appendChild(sender);
    container.appendChild(text);
    container.appendChild(createdon);
    chat.appendChild(container);
}
