import React from 'react';
import { Emoji } from './Emoji';

const A: React.FC = () => {
    const emoji: string = '🍌';
    return (
        <Emoji emoji={emoji} />
    );
}

export default A;