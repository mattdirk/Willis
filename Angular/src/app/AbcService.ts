import { Injectable } from '@angular/core';

@Injectable({ providedIn: 'root' })
export class AbcService {
  async GetAbcData(personId: number): Promise<IAbcData> {
    await this.asyncTimeout(500);

    return {
      result: Math.random() < 0.5,
      personId,
    };
  }

  asyncTimeout(ms: number) {
    return new Promise((resolve) => setTimeout(resolve, ms));
  }
}

export interface IAbcData {
  result: boolean;
  personId: number;
}
