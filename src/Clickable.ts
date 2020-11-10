export abstract class Clickable{
    private sprite: any;
    constructor(sprite: any){
        this.sprite = sprite;
    }

    getSprite(): any{
        return this.sprite;
    }
    abstract interact(): void;
}