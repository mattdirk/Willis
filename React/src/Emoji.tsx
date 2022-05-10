import React from 'react';

const Emoji: React.FC<{
    emoji: string;
  }> = ({ emoji, }) => {
  return (
    <h1>
        {emoji}
    </h1>
  );
}

export { Emoji };