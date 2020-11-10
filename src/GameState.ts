import { RoomScene } from "./Scene";

export class GameState {
    private currentScene: RoomScene;
    private bgImage: string;

    getBgImage(): string{
        return this.bgImage;
    }

    gotoScene(scene) {
        this.currentScene = scene;
        this.bgImage = this.currentScene.getBgImage();
    }
}