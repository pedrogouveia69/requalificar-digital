var my_health = 500;
var enemy_health = 500;
var hit_dmg = Math.floor(Math.random() * (100 - 75 + 1)) + 75;
var turn = false;

window.onload = function coin_toss() {
    if (Math.floor(Math.random() * 2) == 1) {
        turn = true;
    }
    switchControls();
}

function hit() {

    if (!turn) {
        enemy_health -= hit_dmg;
        my_health -= (hit_dmg / 2);
        turn = true;
    }
    else {
        my_health -= hit_dmg;
        enemy_health -= (hit_dmg / 2);
        turn = false;
    }

    change_health_color(enemy_health, "enemyHealth");
    change_health_color(my_health, "myHealth");

    document.getElementById("enemyHealth").style.width = enemy_health + "px";
    document.getElementById("myHealth").style.width = my_health + "px";

    if (enemy_health <= 0 || my_health <= 0) {
        gameOver();
    }
    else {
        switchControls();
    }
}

function heal() {

    if (!turn) {
        if (my_health + hit_dmg >= 500) {
            my_health = 500;
        } else {
            my_health += hit_dmg;
        }
        turn = true;
        change_health_color(my_health, "myHealth");
        document.getElementById("myHealth").style.width = my_health + "px";
    }
    else {
        if (enemy_health + hit_dmg >= 500) {
            enemy_health = 500;
        } else {
            enemy_health += hit_dmg;
        }
        turn = false;
        change_health_color(enemy_health, "enemyHealth")
        document.getElementById("enemyHealth").style.width = enemy_health + "px";
    }

    switchControls();
}

function change_health_color(health, elementId) {

    if (health < (500 / 3)) {
        document.getElementById(elementId).style.backgroundColor = "red";
    }
    else if (health < ((500 / 3) * 2)) {
        document.getElementById(elementId).style.backgroundColor = "yellow";
    }
    else {
        document.getElementById(elementId).style.backgroundColor = "green";
    }
}

function switchControls() {

    if (!turn) {
        document.getElementById("enemy-hit").disabled = true;
        document.getElementById("enemy-heal").disabled = true;

        document.getElementById("hit").disabled = false;
        if (my_health < 500) {
            document.getElementById("heal").disabled = false;
        }

        document.getElementById("turn-indicator").style.textAlign = "left";
    }
    else {
        document.getElementById("hit").disabled = true;
        document.getElementById("heal").disabled = true;

        document.getElementById("enemy-hit").disabled = false;
        if (enemy_health < 500) {
            document.getElementById("enemy-heal").disabled = false;
        }

        document.getElementById("turn-indicator").style.textAlign = "right";
    }
}

function gameOver() {
    
    if (enemy_health <= 0) {
        document.getElementById("enemyHealth").style.width = "0px";
        alert("Player 1 won!");

    }
    else {
        document.getElementById("myHealth").style.width = "0px";
        alert("Player 2 won!");
    }
}