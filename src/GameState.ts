import { RoomScene } from "./Scene";

export class GameState {
    private currentScene: RoomScene;
    private bgImage: string;

    getBgImage(): string{
        return this.bgImage;
    }

    gotoScene(scene) {
        // fade out objects first
        this.currentScene = scene;
        // play room transition
        this.bgImage = this.currentScene.getBgImage();
        // fade in new objects
    }
}