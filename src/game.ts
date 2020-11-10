import 'phaser';
import * as CONST from './Consts';

function preload() {
    
}

function create() {
    
}
function update() {
}

const config = {
    type: Phaser.AUTO,
    width: CONST.CANVAS_WIDTH,
    height: CONST.CANVAS_HEIGHT,
    scene: {
        preload: preload,
        create: create,
        update: update
    },
    physics: {
        default: 'arcade',
        arcade: {
            gravity: { y: 0 },
            debug: false
        }
    }
};

const game = new Phaser.Game(config);
