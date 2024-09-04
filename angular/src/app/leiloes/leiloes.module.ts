import { NgModule } from '@angular/core';
import { SharedModule } from '../shared/shared.module';
import { LeilaoRoutingModule } from './leiloes-routing.module';
import { LeiloesComponent } from './leiloes.component';
import { NgbDatepickerModule } from '@ng-bootstrap/ng-bootstrap'; // add this line

@NgModule({
  declarations: [LeiloesComponent],
  imports: [
    LeilaoRoutingModule,
    SharedModule,
    NgbDatepickerModule, // add this line
  ]
})
export class BookModule { }
