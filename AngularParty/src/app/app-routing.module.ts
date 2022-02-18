import { Component, NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AboutPlayerFormComponent } from './about-player-form/about-player-form.component';
import { AboutplayerListComponent } from './aboutplayer-list/aboutplayer-list.component';
import { GameFormComponent } from './game-form/game-form.component';
import { GameListComponent } from './game-list/game-list.component';
import { PlayerFormComponent } from './player-form/player-form.component';
import { PlayerListComponent } from './player-list/player-list.component';
import { RoomFormComponent } from './room-form/room-form.component';
import { RoomListComponent } from './room-list/room-list.component';
import { WelcomeComponent } from './welcome/welcome.component';

const routes: Routes = [
  {
    path: 'players',
    component: PlayerListComponent
  },
  {
    path: 'createPlayer',
    component: PlayerFormComponent
  },
  {
    path: 'aboutPlayers',
    component: AboutplayerListComponent
  },
  {
    path: 'createAboutPlayer',
    component: AboutPlayerFormComponent
  },
  {
    path: 'games',
    component: GameListComponent
  },
  {
    path: 'createGame',
    component: GameFormComponent
  },
  {
    path: 'rooms',
    component: RoomListComponent
  },
  {
    path: 'createRoom',
    component: RoomFormComponent
  },
  {
  path: 'welcome',
  component: WelcomeComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
