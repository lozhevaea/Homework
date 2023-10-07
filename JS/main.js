function greeting(name) {
    let name1 = name[0].toUpperCase();
    for (let i = 1; i < name.length; i++) {
        name1 += name[i].toLowerCase(); 
    }
    alert(`Здравствуйте, ${name1}!`);
}

const n = prompt('Введите Ваше имя');
console.log(greeting(n));