interface IAbcData {
    result: boolean;
    personId: number;
}

export async function GetAbcData(personId: number): Promise<IAbcData> {

    await asyncTimeout(500);

    return {
        result: Math.random() < 0.5,
        personId
    }
}

function asyncTimeout(ms: number) {
    return new Promise(resolve => setTimeout(resolve, ms));
}