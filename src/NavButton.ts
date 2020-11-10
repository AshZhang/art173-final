import { RoomScene } from "./Scene";
import { Clickable } from "./Clickable";
import { GameState } from "./GameState"

export class NavButton extends Clickable{
    private scene: RoomScene;
    private gameState: GameState;

    constructor(bgImage: string, scene: RoomScene, gameState: GameState){
        super(bgImage);
        this.scene = scene;
        this.gameState = gameState;
    }

    getScene(): RoomScene{
        return this.scene;
    }

    interact(){
        this.gameState.gotoScene(this.scene);
    }
}