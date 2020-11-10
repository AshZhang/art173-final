import { Clickable } from "./Clickable";
import { GameState } from "./GameState";
import { NavButton } from "./NavButton";

export class RoomScene {
    private bgImage: string;
    private objects: Array<Clickable>;
    private sceneNavButtons: Array<NavButton>;
    private gameState: GameState;

    constructor(bgImage: string, gameState: GameState){
        this.bgImage = bgImage;
        this.gameState = gameState;
    }

    getBgImage(): string{
        return this.bgImage;
    }
    
    addObject(obj: Clickable): void{
        this.objects.push(obj);
    }

    addSceneLink(sceneName: string, scene: RoomScene){
        this.sceneNavButtons.push(new NavButton(sceneName, scene, this.gameState));
    }
}