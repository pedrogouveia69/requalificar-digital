var my_health = 500;
var enemy_health = 500;
var hit_dmg = 100;
var heal_amount = 100;

function hit() {
    enemy_health -= hit_dmg;
    if(enemy_health <= 0){
        alert("You won!")
    }
    change_health_color(enemy_health, "enemyHealth");
    my_health -= (hit_dmg / 2);
    change_health_color(my_health, "myHealth");
    document.getElementById("enemyHealth").style.width = enemy_health + "px";
    document.getElementById("myHealth").style.width = my_health + "px";
}

function heal() {
    if (my_health + heal_amount > 500) {
        my_health = 500;
    } else {
        my_health += heal_amount;
    }

    document.getElementById("myHealth").style.width = my_health + "px";
    change_health_color(my_health, "myHealth");
}

function reset() {
    my_health = 500;
    enemy_health = 500;
    change_health_color(my_health, "myHealth");
    change_health_color(enemy_health, "enemyHealth");
    document.getElementById("myHealth").style.width = my_health + "px";
    document.getElementById("enemyHealth").style.width = enemy_health + "px";   
}


function change_health_color(health, elementId) {

    if (health < 166) {
        document.getElementById(elementId).style.backgroundColor = "red";
    }
    else if (health < 333) {
        document.getElementById(elementId).style.backgroundColor = "yellow";
    }
    else{
        document.getElementById(elementId).style.backgroundColor = "green";
    }
}