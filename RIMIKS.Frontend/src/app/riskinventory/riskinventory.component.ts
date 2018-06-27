import { Component, Injector, OnInit, AfterViewInit } from '@angular/core';
import { AppComponentBase } from '@shared/app-component-base';
import { appModuleAnimation } from '@shared/animations/routerTransition';
import{
    Dummy,
    DummyService
} from './dummy.service';

@Component({
    templateUrl: './riskinventory.component.html',
    animations: [appModuleAnimation()],
    providers: [
        DummyService,
    ]
})

export class RiskInventoryComponent extends AppComponentBase implements OnInit {

    dummyData: Dummy[];
    header = 'Risk Inventory';

    constructor(
        injector: Injector,
        private dummyService: DummyService
    ) {
        super(injector);
    }

    ngOnInit() {
        this.header = this.l('RiskInventory');
        this
            .dummyService
            .getDummyData()
            .subscribe((data: object) => {
                console.log(data);
                this.dummyData = data['result'].map(item => new Dummy(item));
            });
    }

    onRowClick(e) {
        console.log(e);
        alert(e.data.Risk);
    }
}


